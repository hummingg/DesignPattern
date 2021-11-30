using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    //监工类，制定盖房子的步骤
    public class Director
    {
        private Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        //制定盖房子的流程，
        public void Construct()
        {
            builder.Dadiji();//先打地基
            builder.QiZhuan();//再砌砖
            builder.FenShua();//最后粉刷
        }
    }
}
