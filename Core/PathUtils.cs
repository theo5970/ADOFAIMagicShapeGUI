using System;

namespace ADOFAIMagicShape
{
    public static class PathUtils
    {
        public static int GetAbsoluteAngle(char path)
        {
            switch (path)
            {
                case 'R': return 0;
                case 'L': return 180;
                case 'U': return 90;
                case 'D': return -90;

                case 'E': return 45;
                case 'Q': return 135;
                case 'Z': return -135;
                case 'C': return -45;

                case 'T': return 60;
                case 'G': return 120;
                case 'F': return -120;
                case 'B': return -60;

                case 'H': return 150;
                case 'N': return -150;
                case 'M': return -30;
                case 'J': return 30;

                case 'p': return 15;
                case 'W': return 165;
                case 'x': return -165;
                case 'A': return -15;

                case 'o': return 75;
                case 'q': return 105;
                case 'V': return -105;
                case 'Y': return -75;

                case '5': return 108;
                default:
                    throw new ArgumentException("지원되지 않는 각도입니다!");

            }
        }
    }
}
