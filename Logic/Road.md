- 4x4 chunks
- 6 chunks required to change direction
- chunk can only be placed if at least 4 chunks away from any other chunk
- randomly select starting chunk from entire left side and first top adjacent and first bottom adjacent
- randomly select direction (of 2 viable)
- at 6th chunk randomly select direction (except backwards)
- if dead end backtrack 1 chunk and try different direction
- connect some roads either after road gen or after adding buildings


rrrrrrrrrrrrrrrr            rrrrrrrrrrrrrrrrrrrrrrrr
rrrrrrrrrrrrrrrr            rrrrrrrrrrrrrrrrrrrrrrrr
rrrrrrrrrrrrrrrr            rrrrrrrrrrrrrrrrrrrrrrrr
rrrrrrrrrrrrrrrr            rrrrrrrrrrrrrrrrrrrrrrrr
rrrrggggggggrrrr            rrrrggggggggggggggggrrrr
rrrrghhhhhhgrrrr            rrrrghhhhhhghhhhhhhgrrrr
rrrrghhhhhhgrrrr            rrrrg              grrrr
rrrrwhhhhhhgrrrr            rrrrg              grrrr
rrrrghhhhhhgrrrr            rrrrg              grrrr
rrrrghhhhhhgrrrr            rrrrg              grrrr
rrrrghhhhhhgrrrr            rrrrg              grrrr
rrrrggggggggrrrr            rrrrg              grrrr
rrrr        rrrrrrrrrrrrrrrrrrrr                rrrr
rrrr        rrrrrrrrrrrrrrrrrrrr                rrrr
rrrr        rrrrrrrrrrrrrrrrrrrr                rrrr
rrrr        rrrrrrrrrrrrrrrrrrrr                rrrr
