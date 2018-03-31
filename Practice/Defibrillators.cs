using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        Defib defibr=null;
        double lon=double.Parse(LON.Replace(",","."));
        double lat=double.Parse(LAT.Replace(",","."));
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            var def=new Defib(DEFIB);
            if(defibr==null) defibr=def;
            else{
                   var dist= def.Distance(lon,lat);
                   if(dist<defibr.Distance(lon,lat)){
                       defibr=def;
                    }
                
                }
           
        }

        Console.WriteLine(defibr.Name);
    }
    
}

internal class Defib{
    public string Id;
    public string Name;
    public string Address;
    public string Contact;
    public double Lon;
    public double Lat;
    public Defib(string d){
        
        string[] rep=d.Split(';');
            Id=rep[0];
            Name=rep[1];
            Address=rep[2];
            Contact=rep[3];
            Lon= double.Parse(rep[4].Replace(",","."));
            Lat= double.Parse(rep[5].Replace(",","."));
        
    }
    
    public  double Distance(double _lon , double _lat){
        
        double x =(this.Lon-_lon) * Math.Cos((_lat+this.Lat)/2);
        
        double y = (this.Lat - _lat);
        
        double d= Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)) * 6371 ;

        return d;
    }
}