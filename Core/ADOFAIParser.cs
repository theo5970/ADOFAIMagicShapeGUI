using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ADOFAIMagicShape
{
    public static class ADOFAIParser
    {
        public static ParseResult Parse(string filePath, bool ignoreTwirls = false)
        {
            List<FloorEvent> events = new List<FloorEvent>();
            JObject levelObj;

            string jsonText = File.ReadAllText(filePath, Encoding.UTF8);

            // 콤마 2개를 ","로 바꿔서 파싱 오류 사전 예방하기
            StringBuilder builder = new StringBuilder(jsonText);
            builder.Replace(", ,", ",");

            levelObj = JObject.Parse(builder.ToString());

            string pathData = levelObj["pathData"].Value<string>();
            JArray actions = levelObj["actions"] as JArray;

            if (ignoreTwirls)
            {
                RemoveTwirlEvents(actions);
            }

            ParsePathData(pathData, events);
            SolveTwirlEvents(actions, events);

            return new ParseResult
            {
                Events = events,
                LevelObject = levelObj
            };
        }

        private static void ParsePathData(string pathData, List<FloorEvent> output)
        {
            for (int i = 0; i < pathData.Length; i++)
            {
                char path = pathData[i];
                bool isTapped = false;

                int angle = PathUtils.GetAbsoluteAngle(path);
                if (i < pathData.Length - 1 && pathData[i + 1] == '!')
                {
                    isTapped = true;

                }

                output.Add(new FloorEvent
                {
                    Floor = i + 1,
                    Angle = angle,
                    IsTabbed = isTapped,
                    HasTwirl = false
                });

                if (isTapped)
                {
                    output.Add(new FloorEvent
                    {
                        Floor = i + 2,
                        Ignore = true
                    });
                    i++;
                }
            }
        }


        private static void RemoveTwirlEvents(JArray actions)
        {
            for (int i = 0; i < actions.Count; i++)
            {
                JObject actionObj = actions[i] as JObject;
                string type = actionObj["eventType"].Value<string>();
                if (type == "Twirl")
                {
                    System.Diagnostics.Debug.WriteLine("Twirl 이벤트 제거됨.");
                    actions.RemoveAt(i);
                    i--;
                }
            }
        }

        private static void SolveTwirlEvents(JArray actions, List<FloorEvent> output)
        {

            foreach (var action in actions)
            {
                JObject actionObj = action as JObject;
                string eventType = actionObj["eventType"].Value<string>();
                if (eventType == "Twirl")
                {
                    int floor = actionObj["floor"].Value<int>();

                    FloorEvent floorEvent = output[floor - 1];
                    floorEvent.HasTwirl = true;
                    output[floor - 1] = floorEvent;
                }
            };

        }


    }
}
