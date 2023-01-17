using System;

using FluentAssertions;

using Xunit;


namespace CraftLR.Exercice3;

public class ConvertisseurDeNombreRomainTest
{
    private readonly ConvertisseurDeNombreRomain _convertisseurDeNombreRomain = new();

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainIDevraitDonner1()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("I");
        Assert.Equal(1, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainIIDevraitDonner2()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("II");
        Assert.Equal(2, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainIIIDevraitDonner3()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("III");
        Assert.Equal(3, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainVDevraitDonner5()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("V");
        Assert.Equal(5, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainVIDevraitDonner6()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("VI");
        Assert.Equal(6, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainIVDevraitDonner4()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("IV");
        Assert.Equal(4, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainXDevraitDonner10()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("X");
        Assert.Equal(10, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainXIDevraitDonner11()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("XI");
        Assert.Equal(11, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainLDevraitDonner50()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("L");
        Assert.Equal(50, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainXLIXDevraitDonner49()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("XLIX");
        Assert.Equal(49, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainCDevraitDonner100()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("C");
        Assert.Equal(100, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainXCIXDevraitDonner99()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("XCIX");
        Assert.Equal(99, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainCCCXLVIDevraitDonner346()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("CCCXLVI");
        Assert.Equal(346, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainCCCXCIXDevraitDonner399()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("CCCXCIX");
        Assert.Equal(399, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainDDevraitDonner500()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("D");
        Assert.Equal(500, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainMDevraitDonner1000()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("M");
        Assert.Equal(1000, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainMMMMDCCCLXXXVIIIDevraitDonner4888()
    {
        int nombre = _convertisseurDeNombreRomain.EnNombreArabe("MMMMDCCCLXXXVIII");
        Assert.Equal(4888, nombre);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainZDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("Z"));
    }


    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainILDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("IL"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void LeChiffreRomainICDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("IC"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void LeChiffreRomainIDDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("ID"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void LeChiffreRomainIMDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("IM"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void LeChiffreRomainVXDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("VX"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void LeChiffreRomainXDDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("XD"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void LeChiffreRomainXMDevraitDonnerUneException()
    {
        Assert.Throws<ArgumentException>(() => _convertisseurDeNombreRomain.EnNombreArabe("XM"));
    }
}
