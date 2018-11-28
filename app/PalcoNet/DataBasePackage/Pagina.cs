using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.DataBasePackage
{
    public class Pagina
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

        public void Next()
        {
            this.pageNumber = pageNumber + 1;
        }

        public void Previous()
        {
            var r = pageNumber - 1;
            this.pageNumber = r <= 0 ? 1 : r;
        }
    }
}
