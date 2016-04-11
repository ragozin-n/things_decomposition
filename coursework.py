import random
import array

elements = [ ]
containers = [ ]

for value in xrange(0,4):
    elements.append(random.random())
elements.sort()

#Write to containers

for namb in containers:
    print namb

print "---------------"

for value in elements:
    print value
