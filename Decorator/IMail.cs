using Sempati.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sempati
{
   public interface IMail
    {

        bool Gonder(iletisim model);
    }
}
