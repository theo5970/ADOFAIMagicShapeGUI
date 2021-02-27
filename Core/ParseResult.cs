using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ADOFAIMagicShape
{
    public struct ParseResult
    {
        public JObject LevelObject;
        public List<FloorEvent> Events;
    }
}
