package bungieAPI

type DestinyLeaderboard struct {
	StatId  string                    `json:"statId"`
	Entries []DestinyLeaderboardEntry `json:"entries"`
}
