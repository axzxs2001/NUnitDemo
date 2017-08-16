describe("A suite of basic functions", function() {
    it("reverse word",function(){
        expect("DCBA").toEqual(reverse("ABCD"));    
 		expect("dcba1").toEqual(reverse("abcd"));  
    });
});