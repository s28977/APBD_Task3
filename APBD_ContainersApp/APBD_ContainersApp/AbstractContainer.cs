﻿namespace APBD_ContainersApp;

public abstract class AbstractContainer
{
    private static int s_id = 1;
    public int ID { get;  }
    public int Height { get; }
    public int TareWeight { get; }
    public int Depth { get; }
    public int MaxPayload { get; }
    public abstract string Type { get; }
    private int _cargoMass;
    public string Serial => $"KON-{Type}{ID}";

    public AbstractContainer(int height, int tareWeight, int depth, int maxPayload)
    {
        ID = s_id++;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        MaxPayload = maxPayload;
    }
    
    
    public void Empty()
    {
        _cargoMass = 0;
    }

   public virtual void Load(int mass)
   {
       if (mass > MaxPayload)
       {
           throw new OverfillException($"Cargo mass cannot be greater then maximum payload = {MaxPayload}");
       }
       _cargoMass = mass;
   }
}