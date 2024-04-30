//Arquivo envia para FILESTREAM, que o mesmo envia para Stream Reader
string path = @"c:\temp\file1.txt";
FileStream fs = null;
StreamReader sr = null;
try
{
    // AQUI SERVE PARA AS FUNÇÕES QUE DEVE SER FEITA NO ARQUIVO
   
    //fs = new FileStream(path, FileMode.Open, FileAccess.Read);
    //sr = new StreamReader(fs);

    //um outro metodo de filestream, file e file info já nos ajuda nestas opções

    sr = File.OpenText(path);

    while (!sr.EndOfStream)
    {
    string line = sr.ReadLine();
        Console.WriteLine(line);
    }
    // isto é uma comunicação com o S.O, deste modo é necessario o seu fechamento manualmente
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);

}
finally
{
    //forma de se fechar manualmente o STREAM READER e FILE READER
    if (sr != null)
        sr.Close();

    //if (fs != null) 
    //    fs.Close();    
}