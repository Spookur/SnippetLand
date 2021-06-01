using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsertingFiles.Models
{
    public class SoundModel
    {
        public int SoundId { get; set; }
        public string SoundPath { get; set; }
        public string SoundExt { get; set; }
        public string SoundName { get; set; }
    }
}