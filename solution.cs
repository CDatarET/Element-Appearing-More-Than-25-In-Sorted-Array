public class Solution {
    public int FindSpecialInteger(int[] arr) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < arr.Length; i++){
            if(d.ContainsKey(arr[i])){
                d[arr[i]] = d[arr[i]] + 1;
            }
            else{
                d[arr[i]] = 1;
            }
        }

        int max = 0;
        int ret = 0;
        foreach(int x in d.Keys){
            if(d[x] > max){
                max = d[x];
                ret = x;
            }
        }

        return(ret);
    }
}
