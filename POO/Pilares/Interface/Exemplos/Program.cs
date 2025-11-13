using Exemplos;
Console.Clear();

ControleRemoto controleTv = new ControleRemoto();

controleTv.NivelVolume = 32;
controleTv.Ligar();
controleTv.AumentarVolume();
controleTv.DiminuirVolume();
controleTv.Desligar();