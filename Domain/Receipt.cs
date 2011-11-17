using System;
using System.Collections.Generic;

namespace ShoeboxedService.Domain
{
    public class Receipt
    {
        public string Store { get; private set; }
        public Guid Id { get; private set; }
        public string Total { get; private set; }
        public string DocumentCurrency { get; private set; }
        public string AccountCurrency { get; private set; }
        public int ConversionRate { get; private set; }
        public double DocumentTotal { get; private set; }
        public double ConvertedTotal { get; private set; }
        public string FormattedDocumentTotal { get; private set; }
        public string FormattedConvertedTotal { get; private set; }
        public double? DocumentTax { get; private set; }
        public double? ConvertedTax { get; private set; }
        public string FormattedDocumentTax { get; private set; }
        public string FormattedConvertedTax { get; private set; }
        public DateTime ModifiedDate { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime Selldate { get; private set; }

        public IList<Image> Images { get; private set; }
        public IList<Category> Categories { get; private set; }

        public Receipt()
        {
            Images = new List<Image>();
            Categories = new List<Category>();
        }

        public Receipt(string store, Guid id, string total, string documentCurrency, string accountCurrency,
            int conversionRate, double documentTotal, double convertedTotal, string formattedDocumentTotal,
            string formattedConvertedTotal, double? documentTax, double? convertedTax, string formattedDocumentTax,
            string formattedConvertedTax, DateTime modifiedDate, DateTime createdDate, DateTime sellDate)
        {
            Store = store;
            Id = id;
            Total = total;
            DocumentCurrency = documentCurrency;
            AccountCurrency = accountCurrency;
            ConversionRate = conversionRate;
            DocumentTotal = documentTotal;
            ConvertedTotal = convertedTotal;
            FormattedDocumentTotal = formattedDocumentTotal;
            FormattedConvertedTotal = formattedConvertedTotal;
            DocumentTax = documentTax;
            ConvertedTax = convertedTax;
            FormattedDocumentTax = formattedDocumentTax;
            FormattedConvertedTax = formattedConvertedTax;
            ModifiedDate = modifiedDate;
            CreatedDate = createdDate;
            Selldate = sellDate;
        }

        public void SetImageList(IList<Image> images)
        {
            Images = images;
        }

        public void AddImages(Image image)
        {
            Images.Add(image);
        }

        public void SetCategoriesList(IList<Category> categories)
        {
            Categories = categories;
        }

        public void AddCategories(Category category)
        {
            Categories.Add(category);
        }
    }
}
