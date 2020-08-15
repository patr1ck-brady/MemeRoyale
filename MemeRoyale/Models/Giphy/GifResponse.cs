using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Models.Giphy
{
    public class GifResponse
    {
        public ICollection<Gif> Data { get; set; }
    }

    public class Gif
    {
        public string Embed_Url { get; set; }
    }
}
