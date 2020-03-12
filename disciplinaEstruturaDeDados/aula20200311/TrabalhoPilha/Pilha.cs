class Pilha {
    string [] elementos;
    int topo = -1;
    int quantidade;
    
    public void Push(string valorASerEmpilhado)
    {
        if(Cheia()) {
            return quantidade += 1 = topo;
        } else {
            topo += 1;
            elementos[topo] = valorASerEmpilhado;
        }
    }

    public void Cria()
    {

    }

    public bool Cheia()
    {
        if(Count() > quantidade-1){
            return true;
        }
    }

    public int Count()
    {
        //int quantidade = elementos.Count;
        for(i=1; i<(topo+1); i++){
            return quantidade;
        }
    }
}