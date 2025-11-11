class Solution:
    def findSpecialInteger(self, arr):
        c = Counter(arr)
        m = 0
        ret = 0
        for x in c:
            if c[x] > m:
                m = c[x]
                ret = x
        
        return ret
