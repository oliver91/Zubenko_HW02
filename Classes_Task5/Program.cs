using System;

namespace Classes_Task5
{
    class Program
    {
        static void Main()
        {
            ClassRoom CRoom = new ClassRoom(new BadPupil(), new GoodPupil(), new ExcelentPupil());
            CRoom.PrintAllPupilsProgress();
            Console.ReadKey();
        }
    }

    internal class ClassRoom
    {
        public Pupil[] pupils;

        public ClassRoom(Pupil p1, Pupil p2)
        {
            pupils = new Pupil[2];
            pupils[0] = p1;
            pupils[1] = p2;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupils = new Pupil[3];
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupils = new Pupil[4];
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        public void PrintAllPupilsProgress()
        {
            foreach(Pupil p in pupils)
                p.PrintPupilProgress();
        }
    }

    internal class Pupil
    {
        private Pupil this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }

        public virtual void Study()
        {
            Console.WriteLine("pupil: studying");
        }

        public virtual void Read()
        {
            Console.WriteLine("pupil: reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("pupil: writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine("pupil: relaxing");
        }

        public void PrintPupilProgress()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }

    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil: studying excellently");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil: reading excellently");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil: writing excellently");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil: relaxing excellently");
        }
    }

    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil: studying good");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil: reading good");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil: writing good");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil: relaxing good");
        }
    }

    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil: studying bad");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil: reading bad");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil: writing bad");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil: relaxing bad");
        }
    }

}
