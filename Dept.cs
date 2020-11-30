using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT8a
{
    class Dept

    {
        public string Name { get; set; }
        public string Id { get; set; }

        ArrayList faculties;
        public Dept(string name, string id)
        {
            Name = name;
            Id = id;

        }
        static void Main(string[] args)
        {
            Faculty f = new Faculty("IMDAD", "000212");

            ArrayList list = new ArrayList();
            list.Add(f);
            list.Add(10);

            f.Show();

        }



        public void AddFaculty(params Faculty[] faculties)
        {
            foreach (Faculty f in faculties)
            {
                this.faculties.Add(f);
            }
        }



    }
}