using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {


           // //Creating Blog object
           //Blogs bsObj = new Blogs()
           //{
           //    Name = "estradawebgroup",
           //    Description = "Compartir conocimiento"
           //};
           // //Convert Blog object to JOSN string format
           // string jsonData = JsonConvert.SerializeObject(bsObj);
           // Console.Write(jsonData);
           // Console.ReadKey();

            string json = @"{
'Unidad': '907535223st',
'Descripcion': 'UB 1525',
}";

            Blogs m = JsonConvert.DeserializeObject<Blogs>(json);
            Console.Write(m.Unidad);
            Console.WriteLine(m.Descripcion);
            Console.ReadKey();


        }
    }
}
