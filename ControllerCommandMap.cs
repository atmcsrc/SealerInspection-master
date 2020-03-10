using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusAPI;

namespace ATMC.App.SealerInspection
{
    public class ControllerCommandItem: IJsonSerializable 
    {
        public string Function { get; set; }
        public string Command{ get; set; }
        public string Text{ get; set; }
        public string Name{ get; set; }

        public void Read(Json node)
        {
            Function = node["Function"].GetString("None");
            Command = node["Command"].GetString("None");
            Text= node["Text"].GetString("None");
            Name= node["Name"].GetString("None");
        }

        public void Write(Json node) { throw new NotImplementedException(); }
    }
}
