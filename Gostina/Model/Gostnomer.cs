//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gostina.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gostnomer
    {
        public int IdGost { get; set; }
        public string Numbernomer { get; set; }
        public string Numberseats { get; set; }
        public string Numberrooms { get; set; }
        public string Bathroom { get; set; }
        public string Equipment { get; set; }
        public string Img { get; set; }
    
        public virtual Zacebece Zacebece { get; set; }
    }
}
