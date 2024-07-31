namespace KiemTraThu
{
    public class MusicStuff
    {
        public MusicStuff()
        {
        }

        public MusicStuff(string iD, string name, string author, int length, string musicProducer)
        {
            ID = iD;
            Name = name;
            Author = author;
            Length = length;
            MusicProducer = musicProducer;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public string MusicProducer { get; set; }
        public class MusicService
        {
            public List<MusicStuff> musics = new List<MusicStuff>();
            public void Add(MusicStuff music)
            {
                musics.Add(music);
            }
            //public void Update(string id, string newName, string Author, int Length, string MusicProducer)
            //{
            //    var x = musics.FirstOrDefault(i => i.ID == id);
            //    if (x != null)
            //    {
            //        x.Name = newName;
            //        x.Author = Author;
            //        x.Length = Length;
            //        x.MusicProducer = MusicProducer;
            //    }
            //}
            public void Delete(string id)
            {
                musics.RemoveAll(i => i.ID == id);
            }
        }
    }
}
