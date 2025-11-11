class Solution {
    public int findSpecialInteger(int[] arr) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        for(int i = 0; i < arr.length; i++){
            map.put(arr[i], map.getOrDefault(arr[i], 0) + 1);
        }

        int max = 0;
        int ret = 0;
        for(int x : map.keySet()){
            if(map.get(x) > max){
                max = map.get(x);
                ret = x;
            }
        }

        return(ret);
    }
}
