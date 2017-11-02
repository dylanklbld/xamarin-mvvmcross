using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Core.Model.Audio
{
    using Base;
    public class Audio : BaseModel
    {
        public virtual string Title { get; set; }


        public virtual Artist Artist { get; set; }
        public virtual Album Album { get; set; }

        public virtual string Meta { get; set; }

        public virtual string Genre { get; set; }

    }
}
