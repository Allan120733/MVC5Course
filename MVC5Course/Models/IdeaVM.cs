using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public enum IdeaType
    {
        爛透了,
        很棒,
        普通
    }
    public class IdeaVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IdeaType IdeaType { get; set; }
    }
}