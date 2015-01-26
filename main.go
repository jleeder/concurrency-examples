package main

import "sync"
import "fmt"
//import "time"
import "math/rand"

func test (wg *sync.WaitGroup, i int) {
    //update data
	defer wg.Done()
    //randTime := time.Duration(rand.Intn(5))
	//time.Sleep(randTime * time.Second)
	k := 0
	fmt.Println("starting loop")
	for j := 0; j < rand.Intn(100) * 10000; j++ {
		k += j
	}
	fmt.Println(i)
    return
}

func main() {
    var wg sync.WaitGroup
    for i := 0; i < 10; i++ {
        wg.Add(1)
        go test(&wg, i)
    }
    
	fmt.Println("Waiting...")

	wg.Wait()
    
    fmt.Println("Done")
}