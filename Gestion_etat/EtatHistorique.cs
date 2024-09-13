namespace Program
{
    public class EtatHistorique
    {

        public Etat PrevEtat {  get; private set; }
        public Etat NextEtat { get; private set; }
        public DateTime DateTime { get; private set; }
        public string Description { get; private set; }

        public EtatHistorique(Etat prevEtat, Etat nextEtat, string description)
        {
            PrevEtat = prevEtat;
            NextEtat = nextEtat;
            DateTime = DateTime.Now;
            Description = description;
        }

        public override string ToString()
        {
            return $"{DateTime}: {PrevEtat} -> {NextEtat} ({Description})";
        }

    }
}