using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4Carver
{
    public class Item
    {
        public string filename { get; set; }

        public string Fullpath { get; set; }

        public int Sizes { get; set; }

        public string Created { get; set; }

        public string Modified { get; set; }

        public string Accessed { get; set; }

        public bool IsDeleted { get; set; }
    }

    public class GetNameData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
