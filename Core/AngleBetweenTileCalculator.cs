using System.Collections.Generic;

namespace ADOFAIMagicShape
{
    public class AngleBetweenTileCalculator
    {
        public List<TileAngle> Result { get; }
        private int lastAngle = 0;

        public AngleBetweenTileCalculator()
        {
            Result = new List<TileAngle>();
        }

        public void Calculate(List<FloorEvent> floorEvents)
        {
            Result.Clear();

            bool twirlFlag = false;
            for (int i = 0; i < floorEvents.Count; i++)
            {
                FloorEvent floorEvent = floorEvents[i];
                if (floorEvent.Ignore)
                {
                    if (floorEvent.HasTwirl)
                    {
                        twirlFlag = !twirlFlag;
                        // Console.WriteLine("Twirl Toggle.");
                    }
                    continue;
                }

                int angle = floorEvent.Angle;
                int betweenAngle = 180 + (lastAngle - angle);

                // 5각형 (불안정)
                if (angle == 108) betweenAngle = 108;

                if (betweenAngle > 360)
                {
                    betweenAngle = betweenAngle % 360;
                }
                else if (betweenAngle <= 0)
                {
                    betweenAngle = 360 + betweenAngle;
                }

                if (twirlFlag)
                {
                    betweenAngle = 360 - betweenAngle;
                }

                // Console.WriteLine("Angle: {0}, Last Angle: {1} => Between Angle: {2}", angle, lastAngle, betweenAngle);

                Result.Add(new TileAngle
                {
                    Floor = floorEvent.Floor,
                    Angle = betweenAngle
                });

                // 탭드타일 추가 계산
                if (floorEvent.IsTabbed)
                {
                    lastAngle = angle + 180;
                }
                else
                {
                    lastAngle = angle;
                }

                // 소용돌이 계산
                if (floorEvent.HasTwirl)
                {
                    twirlFlag = !twirlFlag;
                    // Console.WriteLine("Twirl Toggle.");
                }
            }
        }
    }
}
