using System;

namespace TE19A_Inkapsling_Properties
{
  public class Fighter
  {

    public int Xp {get; private set;}

    // private int xp = 0;

    // public int Xp
    // {
    //   get
    //   {
    //     return xp;
    //   }
    //   set
    //   {
    //     xp = value;
    //   }
    // }

    public int Level
    {
      get
      {
        return xp / 10;
      }
      private set
      {
        xp = value * 10;
      }
    }



    private int hp = 100;

    public int Hp
    {
      get
      {
        return hp;
      }
      set
      {
        hp = value;
        hp = Math.Max(0, hp);
      }
    }


    public int GetHp()
    {
      return hp;
    }

    public void SetHp(int value)
    {
      hp = value;
      hp = Math.Max(0, hp);
    }
  }
}