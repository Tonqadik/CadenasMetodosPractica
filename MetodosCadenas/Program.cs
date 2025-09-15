
using System.ComponentModel.Design;
using System.IO;

string workingDirectory = Environment.CurrentDirectory; // Directorio del proyecto
string directorio = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "/";
string pathResultado = directorio + "resultado.txt";
string[] textoArray = File.ReadAllLines(directorio + "cuento.txt");
string texto = "";
string resultadoFinalTexto = "";
string nombrePersonaje = "Bitin";
string metaCadena = "un tesoro escondido";
string variante1 = "mundo";
string variante2 = "nube";




for (int i = 0; i < textoArray.Length; i++)
{
    texto += textoArray[i];
}

//////////////////////////// SECCIÓN DE CREACIÓN Y CONVERSIÓN
// Concat()
resultadoFinalTexto += $"1.Concat(): Se une el nombre del personaje {nombrePersonaje} con la palabra explorador.\n" + string.Concat(nombrePersonaje," explorador") + "\n\n";

// Join()
resultadoFinalTexto += "2.Join(): Se separa el cuento por oraciones con . y se une con | .\n" + string.Join(".",texto) + "\n\n";

// Format()
resultadoFinalTexto += "3.Format(): Se muestra información en consola.\n" + string.Format("El cuento tiene {0} caracteres y {1} palabras.", texto.Length, texto.Split(' ').Length) + "\n\n";

// Interpolation()
resultadoFinalTexto += $"4.Interpolation(): Se muestra un mensaje interpolado.\nEl protagonista es {nombrePersonaje} y busca {metaCadena}\n\n";

// ToString()
resultadoFinalTexto += $"5.ToString(): Convierte unn número en cadena.\nLa longitud del cuento es de { texto.Length.ToString() }\n\n";

///////////////////////////// SECCIÓN BÚSQUEDA Y LOCALIZACIÓN
// IndexOf()
string varianteIndexOf = "mundo";
resultadoFinalTexto += $"6.IndexOf(): Encuentra la primera posición en donde aparece la palabra {varianteIndexOf}.\nLa posición de la palabra {varianteIndexOf} es en {texto.IndexOf(varianteIndexOf)}\n\n";

// LastIndexOf()
string varianteLastIndex = "ceros";
resultadoFinalTexto += $"7.LastIndexOf(): Encuentra la ultima posición en donde aparece la palabra {varianteLastIndex}.\nLa posición de la palabra {varianteLastIndex} es en {texto.LastIndexOf(varianteLastIndex)}\n\n";

// Contains()
string varianteContains = "nube";
resultadoFinalTexto += $"8.Contains(): Verifica si contiene la palabra {varianteContains}.\n";
if (texto.Contains(varianteContains)) resultadoFinalTexto += $"Contiene la palabra {varianteContains}\n\n"; else resultadoFinalTexto += $"No contiene la palabra {varianteContains}\n\n";

// StartsWith()
string varianteStart = "El vasto universo";
resultadoFinalTexto += $"9.StartsWith(): Comprueba si empieza con {varianteStart}.\n";
if (texto.StartsWith(varianteLastIndex)) resultadoFinalTexto +=  $"Si empieza con {varianteStart}\n\n"; else resultadoFinalTexto += $"No empieza con {varianteStart}\n\n";

// EndssWith()
string varianteEnd = "ceros y unos";
resultadoFinalTexto += $"10.EndssWith(): Comprueba si termina con {varianteEnd}.\n";
if (texto.StartsWith(varianteEnd)) resultadoFinalTexto += $"Si termina con {varianteEnd}\n\n"; else resultadoFinalTexto += $"No termina con {varianteEnd}\n\n";


///////////////////////////// SECCIÓN DE MANIPULACIÓN DE CONTENIDO
// Substring
resultadoFinalTexto += "11.Substring(): Extraer la palabra 'ciudades luminosas'.\n" + texto.Substring(texto.IndexOf("ciudades luminosas"), "ciudades luminosas".Length) + "\n\n";

// Remove()
resultadoFinalTexto += "12.Remove(): Elimina los 15 primeros carácteres.\n" + texto.Remove(0,15) + "\n\n";

// Replace()
resultadoFinalTexto += $"13.Replace(): Sustituye las apariciones de {nombrePersonaje} por ProgramaX.\n" + texto.Replace(nombrePersonaje,"ProgramaX") + "\n\n";

// Insert()
resultadoFinalTexto += "14.Insert(): Inserta la palabra 'IMPORTANTE' después de la palabra 'firewall'.\n" + texto.Insert(texto.IndexOf("firewall"), " IMPORTANTE ") + "\n\n";

// PadLeft()
resultadoFinalTexto += $"15.PadLeft(): Rellena la palabra {nombrePersonaje} a la izquierda hasta tener 10 caráracteres.\n" + texto.Replace(nombrePersonaje,nombrePersonaje.PadLeft(10)) + "\n\n";

// PadRight()
resultadoFinalTexto += $"16.PadRight(): Rellena la palabra {nombrePersonaje} a la derecha hasta tener 12 caráracteres.\n" + texto.Replace(nombrePersonaje,nombrePersonaje.PadRight(12)) + "\n\n";

// Trim()
resultadoFinalTexto += "17.Trim(): Toma un fragmento con espacios extra ' firewall ' y elimina los espacios.\n" + texto.Substring(texto.IndexOf(" firewall ")," firewall ".Length).Trim() + "\n\n";

// TrimStart()
resultadoFinalTexto += "18.TrimStart(): Elimina solo los espacios iniciales de la frase 'Mundo binario'.\n" + texto.Substring(texto.IndexOf(" Mundo binario"), " Mundo binario".Length).TrimStart() + "\n\n";

// TrimEnd()
resultadoFinalTexto += "19.TrimEnd(): Elimina solo los espacios finales de la frase 'Bitin explorador'.\n" + texto.Substring(texto.IndexOf("Bitin explorador "), " Bitin explorador ".Length).TrimEnd() + "\n\n";

// Split()
string[] palabrasSplit = texto.Split(' ');
int z = 0;
resultadoFinalTexto += "20.Split(): Divide el cuento en palabras individuales y muestra las primeras 10.\n";
foreach(var palabra in palabrasSplit)
{
    if (z < 10) resultadoFinalTexto += $"{palabra}\n";
    z++;
}
resultadoFinalTexto += "\n";

////////////////////////////// SECCIÓN DE COMPARACIÓN Y VALIDACIÓN
// Equals()
if ("Nube".Equals("nube")) resultadoFinalTexto += "21.Equals(): Compara Nube y nube.\nSon iguales\n\n"; else resultadoFinalTexto += "21.Equals(): Compara Nube y nube.\nNo son iguales\n\n";


// Compare()
resultadoFinalTexto += "22.Compare(): Compara bitin y firewall e indica quien va primero.\n" + texto.ToUpper() + "\n\n";

// CompareTo()
resultadoFinalTexto += "23.CompareTo(): Aplicar compareTo() y explicar el resultado númerico.\n" + texto.ToLowerInvariant() + "\n\n";

// IsNullorEmpty()
resultadoFinalTexto += "24.IsNullorEmpty(): Declara cadena vacia y verifica si lo es.\n" + texto.ToUpperInvariant() + "\n\n";
if (string.IsNullOrEmpty("")) resultadoFinalTexto += "Si es una cadena vacia.\n\n"; else resultadoFinalTexto += "No es una cadena vacia.\n\n";

// IsNullOrWhiteSpace()
resultadoFinalTexto += "25.IsNullOrWhiteSpace(): Declara cadena con solo un espacio y verifica.\n" + texto.ToUpperInvariant() + "\n\n";
if (string.IsNullOrWhiteSpace(" ")) resultadoFinalTexto += "Contiene un espacio.\n\n"; else resultadoFinalTexto += "No contiene un espacio.\n\n";


/////////////////////////////// SECCIÓN DE CONVERSIÓN A MAYÚSCULA Y MINÚSCULAS
// ToLower()
resultadoFinalTexto += "26.ToLower(): Se convierte el cuento a minúsculas.\n" + texto.ToLower() +"\n\n";

// ToUpper()
resultadoFinalTexto += "27.ToUpper(): Se convierte el cuento a mayúsculas.\n" + texto.ToUpper() + "\n\n";

// ToLoweInvariant()
resultadoFinalTexto += "28.ToLoweInvariant(): Convierte una palabra a minúscula.\n" + "NUBE".ToLowerInvariant() + "\n\n";

// ToUpperInvariant()
resultadoFinalTexto += "29.ToUpperInvariant(): Convierte una palabra a mayúscula.\n" + "bitin".ToUpperInvariant() + "\n\n";

Console.WriteLine(resultadoFinalTexto);
// Se crea el arhivo.
System.IO.File.WriteAllText(pathResultado, resultadoFinalTexto);