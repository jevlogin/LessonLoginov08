namespace ComplexLibrary
{
    public class Adapter
    {
        IViewInterface concreteView;
        public Adapter(IViewInterface view)
        {
            concreteView = view;
        }

        public void Sum()
        {
            Complex z1;
            var f = Complex.TryParse(concreteView.Number1, out z1);

            Complex z2;
            f &= Complex.TryParse(concreteView.Number2, out z2);

            if (f)
            {
                concreteView.OutputData = Complex.SumComplex(z1, z2).ToString();
            }
        }
    }
}
