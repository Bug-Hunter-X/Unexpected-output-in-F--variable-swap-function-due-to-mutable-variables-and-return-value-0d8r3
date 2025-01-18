let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //expect 20 10

//In F#, mutable variables are passed by reference, 
//so the swap function modifies the original variables x and y.
//However, the swap function doesn't return anything,
//leaving the function call in the main code without affecting the output.
//In order to use the swap function correctly, you should return the swapped values using a tuple or assign the return values back to the original variables.
