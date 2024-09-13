namespace Program
{
    public class ObjetMetier
    {

        private Etat _etatActuel;
        private readonly List<EtatHistorique> _etatHistoriques = new List<EtatHistorique>();

        public ObjetMetier(Etat etatInitial, string description)
        {
            _etatActuel = etatInitial;
            _etatHistoriques.Add(new EtatHistorique(Etat.Null, etatInitial, description));
        }

        public void ChangertEtat(Etat nextEtat, string description)
        {
            if (nextEtat == _etatActuel) {
                throw new InvalidOperationException("Impossible de transitionner vers son état actuel");
            }
            EtatHistorique transition = new EtatHistorique(_etatActuel, nextEtat, description);
            _etatHistoriques.Add(transition);
            _etatActuel = nextEtat;
        }

        public void PrintHistorique()
        {
            foreach (var item in _etatHistoriques)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}