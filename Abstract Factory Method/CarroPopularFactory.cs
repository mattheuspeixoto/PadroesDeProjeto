using System;

namespace absf{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaFerro();
        }

        public override Som montarSom()
        {
            return new TocaFita();
        }
    }
}