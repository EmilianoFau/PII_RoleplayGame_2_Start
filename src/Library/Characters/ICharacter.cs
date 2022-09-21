using System;
namespace RoleplayGame;

public interface ICharacter : IAtacar, IDefensa
{
    int Health {get;}
    void ReceiveAttack(int power);
    void Cure();
}