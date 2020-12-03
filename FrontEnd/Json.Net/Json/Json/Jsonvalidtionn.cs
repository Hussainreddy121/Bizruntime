using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Json
{
    class Jsonvalidtionn
    {
        public static void validation()
        {
            string json = @"{
                          'description' : 'person',
                           'type' : 'object'
                           'properties' : 
                           { 'name' : {'type': 'string'}
                             'age' : {'type': 'number'}
                              'hobbies' {
                                          'type': 'array',
                                          'items': {'type': 'string'}
                                       }
                          }
                         }";
            JsonSchema schema = JsonSchema.Parse(json);
            JObject obj = JObject.Parse(@"{
                              'name': 'hussain',
                               'age' : '22',
                               'hobbies': ['roaming', 'sleeping']
                           }");
            bool valid = obj.IsValid(schema);


        }
    }
}
