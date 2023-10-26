using Gaspar;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vertebrado vertebrado1 = new Vertebrado(
    "perro",
    Color.BLANCO, 
    "mediano", 
    "husky",
    TipoVerdebrado.MAMIFEROS,
    true,
    true,
    false,
    true);



Vertebrado vertebrado2 = new Vertebrado(
    "lagarto",
    Color.NEGRO, 
    "mediano", 
    "americano",
    TipoVerdebrado.REPTILES,
    true,
    false,
    false,
    true);



Invertebrado invertebrado1 = new Invertebrado(
    "caracol",
    Color.AMARILLO,
    "pequeno",
    "goldfish",
    TipoInvertebrado.MOLUSCOS,
    false,
    0,
    true
);



Invertebrado invertebrado2 = new Invertebrado(
    "meduza",
    Color.AZUL,
    "pequeno",
    "spider",
    TipoInvertebrado.ARACNIDO,
    true,
    8,
    false
);

vertebrado1.imprimir();
vertebrado2.imprimir();
invertebrado1.imprimir();
invertebrado2.imprimir();