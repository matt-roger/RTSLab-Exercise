using System.Text;

//above Below
int[] arr = new int[] { 1, 5, 2, 1, 10};
myClass myClass = new myClass();

Console.WriteLine(string.Join(Environment.NewLine,myClass.aboveBelow(arr, 6)));

//string rotation
Console.WriteLine(myClass.stringRotation("MyString", 2));

public class myClass {

    public IDictionary<string, int> aboveBelow(int[] collection, int compare) { 
        int above = 0;
        int below = 0;
        IDictionary<string, int> dict = new Dictionary<string, int>();

        foreach(var item in collection){
            if(item > compare){
                above++;
            }else if(item < compare){
                below++;
            }
        }

        dict["above"] = above;
        dict["below"] = below;
        
        return dict;
    }//end above below

    public String stringRotation(String ogStr, int rot){
        rot = ogStr.Length - rot;
        String rtn = ogStr.Substring(rot, ogStr.Length - rot) + ogStr.Substring(0, rot);
        return rtn;
    }

}


