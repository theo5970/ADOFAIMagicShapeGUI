using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ADOFAIMagicShape
{
    public class MagicShapeMultiplierBuilder
    {
        public List<TileAngle> Input { get; set; }
        public float TargetBpm { get; set; }
        public TwirlMode Mode { get; set; }

        public bool UseBpm { get; set; }

        public MagicShapeMultiplierBuilder()
        {
            Input = new List<TileAngle>();
            TargetBpm = 100;
            UseBpm = false;
        }

        public void RemoveUselessEvents(JArray actions)
        {
            for (int i = 0; i < actions.Count; i++)
            {
                JObject actionObj = actions[i] as JObject;
                string type = actionObj["eventType"].Value<string>();

                bool shouldRemoved = false;
                if (type == "SetSpeed")
                {
                    shouldRemoved = true;
                }
                else if (Mode != TwirlMode.Default)
                {
                    if (type == "Twirl")
                    {
                        shouldRemoved = true;
                    }
                }

                if (shouldRemoved)
                {
                    actions.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Build(JObject levelObj)
        {
            JArray actions = levelObj["actions"] as JArray;
            RemoveUselessEvents(actions);

            if (TargetBpm == 0)
            {
                throw new Exception("TargetBpm을 설정해주세요!");
            }

            float lastSpeed = 1;
            bool twirlFlag = false;

            for (int i = 0; i < Input.Count; i++)
            {
                TileAngle tileAngle = Input[i];

                if (Mode != TwirlMode.Default)
                {
                    if (twirlFlag)
                    {
                        tileAngle.Angle = 360 - tileAngle.Angle;
                    }

                    if (i < Input.Count - 1)
                    {
                        TileAngle nextTileAngle = Input[i + 1];
                        float nextAngleWithTwirl = nextTileAngle.Angle;
                        if (twirlFlag) nextAngleWithTwirl = 360 - nextAngleWithTwirl;

                        if ((Mode == TwirlMode.Inside && nextAngleWithTwirl > 180)
                            || (Mode == TwirlMode.Outside && nextAngleWithTwirl < 180))
                        {
                            actions.Add(BuildTwirlAction(tileAngle.Floor));
                            twirlFlag = !twirlFlag;
                        }
                    }
                }

                if (tileAngle.Angle <= 0)
                {
                    tileAngle.Angle = 360 - tileAngle.Angle;
                }

                float ratio = tileAngle.Angle / 180f;

                if (tileAngle.Floor > 1)
                {
                    float newSpeed;
                    if (UseBpm)
                    {
                        newSpeed = TargetBpm * ratio;
                    }
                    else
                    {
                        newSpeed = ratio;
                    }
                    bool isSpeedEquals = Math.Abs(newSpeed - lastSpeed) < 0.0001f;
                    if (!isSpeedEquals)
                    {
                        float actualSpeed = newSpeed;
                        if (!UseBpm)
                        {
                            actualSpeed = newSpeed / lastSpeed;
                        }
                        actions.Add(BuildSpeedAction(tileAngle.Floor - 1, actualSpeed, !UseBpm));
                    }
                    lastSpeed = newSpeed;
                }
            }
        }

        private JObject BuildSpeedAction(int floor, float value, bool isMultiplier = false)
        {
            JObject speedActionObj = new JObject();
            speedActionObj.Add("floor", floor);
            speedActionObj.Add("eventType", "SetSpeed");
            speedActionObj.Add("speedType", isMultiplier ? "Multiplier" : "Bpm");

            float bpm = isMultiplier ? 100 : value;
            float multiplier = isMultiplier ? value : 1.0f;

            speedActionObj.Add("beatsPerMinute", bpm);
            speedActionObj.Add("bpmMultiplier", multiplier);
            return speedActionObj;
        }

        private JObject BuildTwirlAction(int floor)
        {
            JObject twirlActionObj = new JObject();
            twirlActionObj.Add("floor", floor);
            twirlActionObj.Add("eventType", "Twirl");

            return twirlActionObj;
        }
    }
}
