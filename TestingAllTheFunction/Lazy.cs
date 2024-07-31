using Class1;
using KiemTraThu;
using NUnit.Framework;
using static KiemTraThu.MusicStuff;

namespace TestingAllTheFunction
{
    [TestFixture]
    public class Division
    {
        [Test]
        public void Test1()
        {
            Assert.Throws<DivideByZeroException>(() => Function.Divide(10, 0));
        }
        [Test]
        public void Test2()
        {
            var result = Function.Divide(10, 2);
            var expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test3()
        {
            var result = Function.Divide(25, 5);
            var expected = 5;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test4()
        {
            var result = Function.Divide(6, 2);
            var expected = 3;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test5()
        {
            var result = Function.Divide(81, 9);
            var expected = 9;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    public class Multiplication
    {
        [Test]
        public void Test1()
        {
            Function cal = new Function();
            var result = cal.Multiply(74, 47);
            var expected = 3478;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test2()
        {
            Function cal = new Function();
            var result = cal.Multiply(2, 2);
            var expected = 4;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test3()
        {
            Function cal = new Function();
            var result = cal.Multiply(2, 3);
            var expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test4()
        {
            Function cal = new Function();
            var result = cal.Multiply(3, 3);
            var expected = 9;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test5()
        {
            Function cal = new Function();
            var result = cal.Multiply(1, 1);
            var expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    public class StudentGrader
    {
        [Test]
        public void Test1()
        {
            Function cal = new Function();
            var result = cal.StudentScore(1);
            string expected = "Xếp loại F (Failure!)";
            Assert.That(result, Is.EqualTo(expected));
        }
    }
    public class Add
    {
        private MusicStuff music;

        [SetUp]
        public void Setup()
        {
            music = new MusicStuff();
        }
        [Test]
        public void Test01()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 60, "MusicProducer1");
            musicService.Add(item);
            Assert.That(musicService.musics.Count, Is.EqualTo(1));
        }
        [Test]
        public void Test02()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 59, "MusicProducer1");
            musicService.Add(item);
            Assert.That(musicService.musics.Count, Is.EqualTo(1));
        }
        [Test]
        public void Test03()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 58, "MusicProducer1");
            musicService.Add(item);
            Assert.That(musicService.musics.Count, Is.EqualTo(1));
        }
        [Test]
        public void Test04()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 57, "MusicProducer1");
            musicService.Add(item);
            Assert.That(musicService.musics.Count, Is.EqualTo(1));
        }
        [Test]
        public void Test05()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 56, "MusicProducer1");
            musicService.Add(item);
            Assert.That(musicService.musics.Count, Is.EqualTo(1));
        }
    }
    public class Delete
    {
        private MusicStuff music;

        [SetUp]
        public void Setup()
        {
            music = new MusicStuff();
        }

        [Test]
        public void Test01()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 60, "MusicProducer1");
            musicService.Add(item);
            musicService.Delete(item.ID);
            Assert.That(musicService.musics.Count, Is.EqualTo(0));
        }
        [Test]
        public void Test02()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 61, "MusicProducer1");
            musicService.Add(item);
            musicService.Delete(item.ID);
            Assert.That(musicService.musics.Count, Is.EqualTo(0));
        }
        [Test]
        public void Test03()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 62, "MusicProducer1");
            musicService.Add(item);
            musicService.Delete(item.ID);
            Assert.That(musicService.musics.Count, Is.EqualTo(0));
        }
        [Test]
        public void Test04()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 63, "MusicProducer1");
            musicService.Add(item);
            musicService.Delete(item.ID);
            Assert.That(musicService.musics.Count, Is.EqualTo(0));
        }
        [Test]
        public void Test05()
        {
            var musicService = new MusicService();
            var item = new MusicStuff("song1", "Product", "Ashley", 64, "MusicProducer1");
            musicService.Add(item);
            musicService.Delete(item.ID);
            Assert.That(musicService.musics.Count, Is.EqualTo(0));
        }
    }
}