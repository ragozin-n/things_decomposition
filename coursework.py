import random
import array

elements = [ ]
containers = [ ]

for value in xrange(0,10000):
    elements.append(random.random())
elements.sort()

#Write to containers

for value in containers:
    print(value)

print("---------------")

for value in elements:
    print(value)
