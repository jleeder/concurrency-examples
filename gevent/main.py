import gevent
from gevent import Greenlet
from time import sleep
import random

def main():
    threads = []
    for i in range(0,10): 
        threads.append(Greenlet.spawn(test,i))

    gevent.joinall(threads)

def test(i):
    #sleep(random.randint(0, 5)) #sleep random seconds
    gevent.sleep(random.randint(0, 5)) #sleep random seconds but gevent lets go of control
    print i #print the i

if __name__ == '__main__': main()