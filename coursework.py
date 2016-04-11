import random
import argparse

parser = argparse.ArgumentParser(description='coursework')
parser.add_argument("containers_count", type=int,
                    help="the number of containers")
args = parser.parse_args()

elements = []
containers = [0]

for value in range(0, 10000):
    elements.append(random.random())
elements.sort(reverse=True)

for value in elements:
    if containers[-1] + value <= 1:
        containers[-1] += value
    else:
        containers.append(value)

if len(containers) > args.containers_count:
    print("not enough containers")
else:
    print(str(len(containers)) + " containers need")
