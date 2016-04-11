import random
import argparse

parser = argparse.ArgumentParser(description='coursework')
parser.add_argument("containers_count", type=int,  help="Number of containers.")
parser.add_argument("element_count", type=int, help="Number of elements to store.")
parser.usage = "coursework.py [Containers count] [Elements count]"
parser.description = "Print's how many containers of 1 kg need to store n element's, who's weight is between 0 and 1."
args = parser.parse_args()

elements = []
containers = [0]

for value in range(0, args.element_count):
    elements.append(random.random())
elements.sort(reverse=True)

for value in elements:
    if containers[-1] + value <= 1:
        containers[-1] += value
    else:
        containers.append(value)

if len(containers) > args.containers_count:
    print("Not enough containers to store " + str(args.element_count) + " element's")
else:
    print(str(len(containers)) + " containers need to store " + str(args.element_count) + " element's")
