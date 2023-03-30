using System;
using System.Text;

namespace hashes;

public class GhostsTask :
        IFactory<Document>, IFactory<Vector>, IFactory<Segment>, IFactory<Cat>, IFactory<Robot>,
        IMagic
{
    Cat cat;
    Document document;
    Vector vector;
    Segment segment;
    Robot robot;

    byte[] fordocument = Encoding.ASCII.GetBytes("New document");
    byte[] hacker = Encoding.ASCII.GetBytes("Im programer");

    public void DoMagic()
    {
        cat?.Rename("Vasya");
        vector?.Add(vector);
        segment?.Start?.Add(segment.Start);

        Robot.BatteryCapacity = 666;

        if (document != null)
            for (int i = 0; i < fordocument.Length; i++)
                fordocument[i] = hacker[i];
    }

    Vector IFactory<Vector>.Create()
    {
        if (vector == null)
            vector = new Vector(1, 1);
        return vector;
    }

    Segment IFactory<Segment>.Create()
    {
        if (segment == null)
            segment = new Segment(new Vector(1, 1), new Vector(1, 1));
        return segment;
    }

    Document IFactory<Document>.Create()
    {
        if (document == null)
            document = new Document("Document", Encoding.UTF8, fordocument); ;
        return document;
    }

    Cat IFactory<Cat>.Create()
    {
        if (cat == null)
            cat = new Cat("Pushistik", "fluffy", DateTime.Now);
        return cat;
    }

    Robot IFactory<Robot>.Create()
    {
        Robot.BatteryCapacity = 123;
        if (robot == null)
            robot = new Robot("1");
        return robot;
    }
}