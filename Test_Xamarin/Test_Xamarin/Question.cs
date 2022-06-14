using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Xamarin
{
    public class Question
    {
        public string questions1;
        public string variant_1;
        public string variant_2;
        public string variant_3;
        public string variant_4;
        public string variant_5;
        public int otvet;
        public string Questions1 { get; set; }
        public string Variant_1 { get; set; }
        public int Otvet { get; set; }
        public string Variant_2 { get; set; }
        public string Variant_3 { get; set; }
        public string Variant_4 { get; set; }
        public string Variant_5 { get; set; }
        public Question() { }
        public Question(string questions1, string variant_1, string variant_2, string variant_3,string variant_4,string variant_5, int otvet)
        {
            this.questions1 = questions1;
            this.variant_1 = variant_1;
            this.variant_2 = variant_2;
            this.variant_3 = variant_3;
            this.variant_4 = variant_4;
            this.variant_5 = variant_5;
            this.otvet = otvet;
        }
    }
}
