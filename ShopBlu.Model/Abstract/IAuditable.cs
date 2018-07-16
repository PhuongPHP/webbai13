using System;

namespace ShopBlu.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}
