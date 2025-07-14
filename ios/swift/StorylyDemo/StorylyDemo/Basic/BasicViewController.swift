//
//  BasicViewController.swift
//  StorylyDemo
//

import UIKit
import Storyly
import AVFoundation
import MediaPlayer

class BasicViewController: UIViewController {
    
    private var audioPlayer: AVAudioPlayer?
    private var currentTrack = 0
    private let trackMap = [
        0: "identify",
        1: "times",
        2: "wall"
    ]
    
    private lazy var storylyView: StorylyView = {
        let _storylyView = StorylyView()
        _storylyView.translatesAutoresizingMaskIntoConstraints = false
        _storylyView.rootViewController = self
        return _storylyView
    }()
    
    private lazy var buttonStackView: UIStackView = {
        let _buttonStackView = UIStackView()
        _buttonStackView.axis = .vertical
        _buttonStackView.translatesAutoresizingMaskIntoConstraints = false
        return _buttonStackView
    }()
    
    private lazy var changeTrackButton: UIButton = {
        let _changeTrackButton = UIButton()
        _changeTrackButton.setTitle("Change Track", for: .normal)
        _changeTrackButton.setTitleColor(UIColor.blue, for: .normal)
        _changeTrackButton.addTarget(self, action: #selector(onChangeTrack(_:)), for: .touchUpInside)
        return _changeTrackButton
    }()
    
    private lazy var playPauseButton: UIButton = {
        let _playPauseButton = UIButton()
        _playPauseButton.setTitle("Play", for: .normal)
        _playPauseButton.setTitle("Pause", for: .selected)
        _playPauseButton.setTitleColor(UIColor.blue, for: .normal)
        _playPauseButton.addTarget(self, action: #selector(onPlayPause(_:)), for: .touchUpInside)
        return _playPauseButton
    }()
    
    private lazy var initStorylyButton: UIButton = {
        let _changeTrackButton = UIButton()
        _changeTrackButton.setTitle("Initialize Storyly", for: .normal)
        _changeTrackButton.setTitleColor(UIColor.blue, for: .normal)
        _changeTrackButton.addTarget(self, action: #selector(onStorylyInit(_:)), for: .touchUpInside)
        return _changeTrackButton
    }()
    
    override func viewDidLoad() {
        super.viewDidLoad()
        self.view.backgroundColor = .white
        
        self.view.addSubview(storylyView)
        storylyView.leadingAnchor.constraint(equalTo: self.view.safeAreaLayoutGuide.leadingAnchor).isActive = true
        storylyView.trailingAnchor.constraint(equalTo: self.view.safeAreaLayoutGuide.trailingAnchor).isActive = true
        storylyView.topAnchor.constraint(equalTo: self.view.safeAreaLayoutGuide.topAnchor, constant: 10).isActive = true
        storylyView.heightAnchor.constraint(equalToConstant: 116).isActive = true
        
        self.view.addSubview(buttonStackView)
        buttonStackView.centerXAnchor.constraint(equalTo: self.view.centerXAnchor).isActive = true
        buttonStackView.centerYAnchor.constraint(equalTo: self.view.centerYAnchor).isActive = true
        self.buttonStackView.addArrangedSubview(initStorylyButton)
        self.buttonStackView.addArrangedSubview(changeTrackButton)
        self.buttonStackView.addArrangedSubview(playPauseButton)
    }
    
    @objc func onPlayPause(_ sender: UIButton) {
        switch playPauseButton.isSelected {
        case true:
            self.pauseAudio()
            sender.isSelected = false
        case false:
            sender.isSelected = true
            self.playAudio()
        }
    }
    
    @objc func onStorylyInit(_ sender: UIButton) {
        storylyView.storylyInit = StorylyInit(storylyId: STORYLY_INSTANCE_TOKEN)
    }
    
    @objc func onChangeTrack(_ sender: UIButton) {
        self.audioPlayer?.pause()
        self.audioPlayer = nil
        self.currentTrack = (currentTrack + 1) % 3
        if playPauseButton.isSelected {
            self.playAudio()
        }
    }
    
}

extension BasicViewController {
    func pauseAudio() {
        audioPlayer?.pause()
    }
    
    func playAudio() {
        if audioPlayer != nil {
            audioPlayer?.play()
            return
        }
        
        do {
            try AVAudioSession.sharedInstance().setCategory(.playback, mode: .default)
            try AVAudioSession.sharedInstance().setActive(true)
        } catch {
            print("Audio session error: \(error)")
        }
        
        guard let url = Bundle.main.url(forResource: trackMap[currentTrack], withExtension: "mp3") else {
            print("Audio file not found.")
            return
        }

        do {
            audioPlayer = try AVAudioPlayer(contentsOf: url)
            audioPlayer?.prepareToPlay()
            audioPlayer?.play()
            self.setupNowPlaying()
        } catch {
            print("Failed to play audio: \(error)")
        }
        
    }
    
    func setupNowPlaying() {
        let nowPlayingInfoCenter = MPNowPlayingInfoCenter.default()
        var nowPlayingInfo: [String: Any] = [:]

        nowPlayingInfo[MPMediaItemPropertyTitle] = "Sample Song \(currentTrack)"
        nowPlayingInfo[MPMediaItemPropertyArtist] = "Sample Artist \(currentTrack)"
        nowPlayingInfo[MPMediaItemPropertyAlbumTitle] = "Sample Album \(currentTrack)"
        nowPlayingInfo[MPNowPlayingInfoPropertyElapsedPlaybackTime] = audioPlayer?.currentTime
        nowPlayingInfo[MPMediaItemPropertyPlaybackDuration] = audioPlayer?.duration
        nowPlayingInfo[MPNowPlayingInfoPropertyPlaybackRate] = audioPlayer?.isPlaying == true ? 1.0 : 0.0
        nowPlayingInfoCenter.nowPlayingInfo = nowPlayingInfo
        
        let commandCenter = MPRemoteCommandCenter.shared()
        commandCenter.playCommand.isEnabled = true
        commandCenter.playCommand.addTarget { [weak self] event in
            self?.playPauseButton.isSelected = true
            self?.audioPlayer?.play()
            return .success
        }

        commandCenter.pauseCommand.isEnabled = true
        commandCenter.pauseCommand.addTarget { [weak self] event in
            self?.audioPlayer?.pause()
            self?.playPauseButton.isSelected = false
            return .success
        }
    }
}
