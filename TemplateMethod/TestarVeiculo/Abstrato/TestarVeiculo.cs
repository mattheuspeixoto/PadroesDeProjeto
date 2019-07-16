namespace tm2.Abstrato{
abstract class TestarVeiculo{

    public abstract void ligar();

    
    public abstract void acelerar();
        
    
    public abstract void freiar();
        
    
    public abstract void desligar();
        
    
    public void testarVeiculo(){
        this.ligar();
        this.acelerar();
        this.freiar();
        this.desligar();

    }

}}
