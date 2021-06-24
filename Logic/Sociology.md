homo/bisexuality allowed
polyamory allowed
interspecial romance forbidden
incest forbidden

relationships are one-directional?

friend/lover forbidden
friend/friendinterest forbidden
friend/enemy forbidden
friend/loverinterest allowed

lover/loverinterests forbidden
lover/enemy forbidden
lover/friendinterest allowed

enemy/friendinterest forbidden
enemy/loverinterest forbidden

friendInterest/friend forbidden
friendInterest/enemy forbidden

loverInterest/lover forbidden
loverInterest/enemy forbidden


family
friends
lovers
friendinterest
loverinterest
enemies

 if (Array.Find(friends, friend =>
                Array.Find(new AAgent[]{
                        Array.Find(friend.Sociology.Lovers, lover => lover.Equals(friend)),
                        Array.Find(friend.Sociology.FriendInterests, friendInterest => friendInterest.Equals(friend)),
                        Array.Find(friend.Sociology.Enemies, enemy => enemy.Equals(friend))
                    }, contradiction => contradiction != null)
            ) == null) this._friends = friends;



public AAgent FindContradictions(AAgent[] agents, params string[] exclusions) {
    return Array.Find(agents, agent => {
        List<AAgent> list = new List<AAgent>();

        foreach (string exclusion in exclusions)
            list.Add(Array.Find(agent.Sociology.GetProperty(exclusion)), member => member.Equals(agent));
        
        return Array.Find(list, element => element != null);
    });
}