using NSubstitute;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTests
{ 
    [Test]
    public void PlayerEntering_PlayerTargetedTrap_Trap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        characterMover.IsPlayer.Returns(true);

        trap.HandleCharacterEntered(characterMover, TrapTargetType.Player);
        Assert.AreEqual(-1, characterMover.Health);
    }

    [Test]
    public void NPCEntering_NPCTargetedTrap_Trap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        trap.HandleCharacterEntered(characterMover, TrapTargetType.NPC);
        Assert.AreEqual(-1, characterMover.Health);
    }
}
