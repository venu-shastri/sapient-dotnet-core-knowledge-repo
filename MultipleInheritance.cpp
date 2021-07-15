lass Printer{
    public: void Print(){ cout<<"Printing Document"<<endl;}
}
class Scanner{
    public:void Scan(){ cout<<"Scanning" Document"<<endl;}
}
class PrintScanner:Printer,Scanner{
    
    
    
}
class DeviceManager{
    
    public:
       void SetPrinter(Printer *printerRef){ printerRef->Print();}
       void SetScanner(Scanner *scannerRef){ scannerRef->Scan();}
       void PrintDocument(){}
       void ScanDocument(){}
}

int main()
{
    DeviceManager *_manager=new  DeviceManager();
    _manager->SetPrinter(new Printer());
    _manager->SetPrinter(new PrintScanner());
    
    _manager-->SetScanner(new Scanner());
    _manager->SetScanner(new PrintScanner());

    return 0;
}
