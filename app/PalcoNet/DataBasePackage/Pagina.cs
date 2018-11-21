using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.DataBasePackage
{
    class Pagina
    {
        public int pageNumber { get; set; }
        public int pageSize { get; set; }

        public Pagina(int pageNumber, int pageSize) {
            this.pageNumber = pageNumber;
            this.pageSize = pageSize;
        }

        public int FirstResultIndex()
        {
            return (pageNumber - 1) * pageSize;
        }

    }
}
