namespace LibrairieConversionNote
{
    
        public class ConversionAlphabetiqueToNote
        {



            public string Transformer(string input)
            {

                List<string> NotesAnglais = new List<string>() { "A", "B", "C", "D", "E", "F", "G" };
                List<string> notes = new List<string>() { "LA", "SI", "DO", "RE", "MI", "FA", "SOL" };


                for (int i = 0; i < NotesAnglais.Count; i++)
                {
                    string position = NotesAnglais[i];

                    if (position == input)
                    {

                        return notes[i];

                    }

                }
                return "option invalide";

            }



        }

}