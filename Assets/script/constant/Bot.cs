using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot
{
    private int[] _position;

    public int MoveBot(int[] position, int cleverness)
    {
        _position = position;

        int first = 0;
        foreach (var i in _position)
        {
            first += i;
        }
        
        if (first == 1)
        {
            var i = Random.Range(0, _position.Length);
            if (_position[i] != 0) i = 4;
            return _position[i] != 0 ? 2 : 7;
        }

        if (Random.Range(0, _position.Length) > cleverness)
        {
            List<int> move = new List<int>();
            for (int i = 0; i < _position.Length; i++)
            {
                if (_position[i] == 0) move.Add(i);
            }

            return move[Random.Range(0, move.Count)];
        }


        if (_position[0] == 0)
            if (_position[1] == 2 && _position[2] == 2 || _position[3] == 2 && _position[6] == 2 ||
                _position[4] == 2 && _position[8] == 2)
                return 0;
        if (_position[1] == 0)
            if (_position[0] == 2 && _position[2] == 2 || _position[4] == 2 && _position[7] == 2)
                return 1;
        if (_position[2] == 0)
            if (_position[0] == 2 && _position[1] == 2 || _position[5] == 2 && _position[8] == 2 ||
                _position[4] == 2 && _position[6] == 2)
                return 2;
        if (_position[3] == 0)
            if (_position[0] == 2 && _position[6] == 2 || _position[4] == 2 && _position[5] == 2)
                return 3;
        if (_position[5] == 0)
            if (_position[4] == 2 && _position[3] == 2 || _position[2] == 2 && _position[8] == 2)
                return 5;
        if (_position[6] == 0)
            if (_position[0] == 2 && _position[3] == 2 || _position[7] == 2 && _position[8] == 2 ||
                _position[4] == 2 && _position[2] == 2)
                return 6;
        if (_position[7] == 0)
            if (_position[6] == 2 && _position[8] == 2 || _position[4] == 2 && _position[1] == 2)
                return 7;
        if (_position[8] == 0)
            if (_position[7] == 2 && _position[6] == 2 || _position[5] == 2 && _position[2] == 2 ||
                _position[4] == 2 && _position[0] == 2)
                return 8;


        if (_position[0] == 0)
            if (_position[1] == 1 && _position[2] == 1 || _position[3] == 1 && _position[6] == 1 ||
                _position[4] == 1 && _position[8] == 1)
                return 0;
        if (_position[1] == 0)
            if (_position[0] == 1 && _position[2] == 1 || _position[4] == 1 && _position[7] == 1)
                return 1;
        if (_position[2] == 0)
            if (_position[0] == 1 && _position[1] == 1 || _position[5] == 1 && _position[8] == 1 ||
                _position[4] == 1 && _position[6] == 1)
                return 2;
        if (_position[3] == 0)
            if (_position[0] == 1 && _position[6] == 1 || _position[4] == 1 && _position[5] == 1)
                return 3;
        if (_position[5] == 0)
            if (_position[4] == 1 && _position[3] == 1 || _position[2] == 1 && _position[8] == 1)
                return 5;
        if (_position[6] == 0)
            if (_position[0] == 1 && _position[3] == 1 || _position[7] == 1 && _position[8] == 1 ||
                _position[4] == 1 && _position[2] == 1)
                return 6;
        if (_position[7] == 0)
            if (_position[6] == 1 && _position[8] == 1 || _position[4] == 1 && _position[1] == 1)
                return 7;
        if (_position[8] == 0)
            if (_position[7] == 1 && _position[6] == 1 || _position[5] == 1 && _position[2] == 1 ||
                _position[4] == 1 && _position[0] == 1)
                return 8;
        if (_position[4] == 0) return 4;


        for (int i = 0; i < _position.Length; i++)
        {
            if (_position[i] == 0) return i;
        }

        return 4;
    }
}