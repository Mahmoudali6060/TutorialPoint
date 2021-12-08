using AbstractFactory.Abstractions;
using AbstractFactory.Concretes;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AbstractShapeFactory abstractShapeFactory = FactoryProducer.GetShape(false);
            IShape shape1 = abstractShapeFactory.GetShape(Enums.ShapeTypeEnum.Rectangle);
            shape1.Draw();

            IShape shape2 = abstractShapeFactory.GetShape(Enums.ShapeTypeEnum.Square);
            shape2.Draw();


            AbstractShapeFactory roundedShapeFactory = FactoryProducer.GetShape(true);

            IShape roundedshape1 = roundedShapeFactory.GetShape(Enums.ShapeTypeEnum.RoundedRectangle);
            roundedshape1.Draw();

            IShape roundedshape2 = roundedShapeFactory.GetShape(Enums.ShapeTypeEnum.RoundedSquare);
            roundedshape2.Draw();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
